﻿using System;

namespace _06___Manual___Exercise_01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o tamanho do vetor: "); int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n]; 
            for(int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = " +avg.ToString("F2"));

        }
    }
}
