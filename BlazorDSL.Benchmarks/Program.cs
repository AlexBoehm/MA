using BenchmarkDotNet.Running;
using BlazorDSL.Benchmarks;

// Führt alle Benchmarks aus und generiert Berichte

Console.WriteLine("=== BlazorDSL Benchmarks ===");
Console.WriteLine("Vergleich der DSL mit Razor-Komponenten");
Console.WriteLine("Starte Benchmarks...");
Console.WriteLine();

var summary = BenchmarkRunner.Run<RenderingBenchmarks>();

Console.WriteLine();
Console.WriteLine("Benchmarks abgeschlossen!");
Console.WriteLine($"Ergebnisse gespeichert in: {summary.ResultsDirectoryPath}");
