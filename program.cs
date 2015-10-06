using System;
using System.IO;

        public class Program {
        	public static void Main(string[] args){
        		Console.WriteLine("Hello World from Core CLR!");
			File.AppendAllText("abc.txt", DateTime.Now.ToString());
        	}
        }
