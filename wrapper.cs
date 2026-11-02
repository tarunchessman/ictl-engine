using System;
using System.Diagnostics;
using System.IO;

class Program {
    static void Main() {
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        string credPath = Path.Combine(baseDir, "credentials.txt");

        if (!File.Exists(credPath)) {
            Console.WriteLine("info string ERROR: credentials.txt not found in engine folder.");
            return;
        }

        string[] lines = File.ReadAllLines(credPath);
        if (lines.Length < 2) {
            Console.WriteLine("info string ERROR: credentials.txt must contain Username on line 1 and Password on line 2.");
            return;
        }

        string username = lines[0].Trim();
        string password = lines[1].Trim();
        string serverIp = "178.63.40.212";

        Process p = new Process();
        p.StartInfo.FileName = Path.Combine(baseDir, "plink.exe");
        p.StartInfo.Arguments = string.Format("-batch -pw \"{0}\" {1}@{2} \"/usr/local/bin/stockfish_session.sh\"", password, username, serverIp);
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardInput = true;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardError = false;
        p.StartInfo.CreateNoWindow = true;

        p.OutputDataReceived += (s, e) => {
            if (e.Data != null) {
                if (e.Data.StartsWith("id name ", StringComparison.OrdinalIgnoreCase)) {
                    Console.WriteLine("id name ICTL Cloud Stockfish 18");
                } 
                else {
                    Console.WriteLine(e.Data);
                }
                Console.Out.Flush();
            }
        };

        p.Start();
        p.BeginOutputReadLine();

        string line;
        while ((line = Console.ReadLine()) != null) {
            if (line.StartsWith("setoption name Threads", StringComparison.OrdinalIgnoreCase)) {
                p.StandardInput.WriteLine("setoption name Threads value 12");
            } 
            else if (line.StartsWith("setoption name Hash", StringComparison.OrdinalIgnoreCase)) {
                p.StandardInput.WriteLine("setoption name Hash value 32768");
            } 
            else {
                p.StandardInput.WriteLine(line);
            }
            p.StandardInput.Flush();
        }

        p.WaitForExit();
    }
}