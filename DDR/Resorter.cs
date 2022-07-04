using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DDR
{
    class Resorter
    {
        public static List<double[]> _inputs = new List<double[]>();
        public static List<double> _target = new List<double>();

        public bool ReadData(string fileName)
        {
            _inputs.Clear();
            _target.Clear();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found {0}", fileName);
                Environment.Exit(0);
                return false;
            }
            string[] lines = System.IO.File.ReadAllLines(fileName);
            for (int m = 0; m < lines.Length; ++m)
            {
                string[] sdata = lines[m].Split(',');
                if (7 != sdata.Length)
                {
                    Console.WriteLine("Misformatted data");
                    Environment.Exit(0);
                }
                double[] data = new double[6];
                for (int i = 0; i < data.Length; ++i)
                {
                    Double.TryParse(sdata[i], out data[i]);
                }
                double targetValue = 0.0;
                Double.TryParse(sdata[6], out targetValue);
                _inputs.Add(data);
                _target.Add(targetValue);
            }
            return true;
        }

        public void Resort(int NBlocks)
        {
            int inputlen = _inputs[0].Length;
            int blocksize = _inputs.Count / NBlocks;
            if (0 != _inputs.Count % NBlocks)
            {
                blocksize += 1;
            }
            List<double[]> blockinput = new List<double[]>();
            List<double> blocktarget = new List<double>();
            int counter = 0;
            List<double[]> sortedinputs = new List<double[]>();
            List<double> sortedtarget = new List<double>();
            for (int j = 0; j < _inputs.Count; ++j)
            {
                double[] x = new double[inputlen];
                for (int k = 0; k < inputlen; ++k)
                {
                    x[k] = _inputs[j][k];
                }
                double t = _target[j];

                blockinput.Add(x);
                blocktarget.Add(t);

                if (++counter >= blocksize || j >= _inputs.Count - 1)
                {
                    KolmogorovModel km = new KolmogorovModel(blockinput, blocktarget, new int[] {4,4,4,4,4,4});
                    int NLeaves = 24;
                    int[] linearBlocksPerRootInput = new int[NLeaves];
                    for (int m = 0; m < NLeaves; ++m)
                    {
                        linearBlocksPerRootInput[m] = 16;
                    }
                    km.GenerateInitialOperators(NLeaves, linearBlocksPerRootInput);
                    km.BuildRepresentation(10, 0.05, 0.05);
                    Console.WriteLine("Modelled to actual output correlation koeff {0:0.00}", km.ComputeCorrelationCoeff());
                    km.SortData();

                    for (int k = 0; k < km._inputs.Count; ++k)
                    {
                        double[] z = new double[inputlen];
                        for (int m = 0; m < inputlen; ++m)
                        {
                            z[m] = km._inputs[k][m];
                        }
                        double t2 = km._target[k];

                        sortedinputs.Add(z);
                        sortedtarget.Add(t2);
                    }

                    blockinput.Clear();
                    blocktarget.Clear();
                    counter = 0;
                }
            }
            Console.WriteLine();

            _inputs.Clear();
            _target.Clear();

            for (int k = 0; k < sortedinputs.Count; ++k)
            {
                double[] z = new double[inputlen];
                for (int m = 0; m < inputlen; ++m)
                {
                    z[m] = sortedinputs[k][m];
                }
                double t2 = sortedtarget[k];

                _inputs.Add(z);
                _target.Add(t2);
            }
            //Console.WriteLine();
        }
    }
}
