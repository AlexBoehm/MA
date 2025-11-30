using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Bunit;
using BlazorDSL.Benchmarks.Components;

namespace BlazorDSL.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class RenderingBenchmarks
{
    private BunitContext? _context;
    private List<TodoItem> _items10 = [];
    private List<TodoItem> _items25 = [];
    private List<TodoItem> _items50 = [];
    private List<TodoItem> _items100 = [];
    private List<TodoItem> _items200 = [];
    private List<TodoItem> _items500 = [];
    private List<TodoItem> _items1000 = [];

    [GlobalSetup]
    public void GlobalSetup()
    {
        _context = new BunitContext();
    }

    [GlobalCleanup]
    public void GlobalCleanup()
    {
        _context?.Dispose();
    }

    [IterationSetup]
    public void IterationSetup()
    {
        _context?.Dispose();
        _context = new BunitContext();

        // TodoItems außerhalb der Benchmark-Messung erstellen
        _items10 = CreateItems(10);
        _items25 = CreateItems(25);
        _items50 = CreateItems(50);
        _items100 = CreateItems(100);
        _items200 = CreateItems(200);
        _items500 = CreateItems(500);
        _items1000 = CreateItems(1000);
    }

    private static List<TodoItem> CreateItems(int count)
    {
        return Enumerable.Range(1, count)
            .Select(i => new TodoItem { Text = $"Aufgabe {i}", Done = i % 3 == 0 })
            .ToList();
    }

    #region Simple Component Benchmarks

    [Benchmark(Description = "Simple Component (DSL)")]
    public void RenderSimpleComponentDSL()
    {
        var cut = _context!.Render<SimpleComponentDSL>();
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Simple Component (Razor)")]
    public void RenderSimpleComponentRazor()
    {
        var cut = _context!.Render<SimpleComponentRazor>();
        var markup = cut.Markup;
    }

    #endregion

    #region Todo Component Benchmarks

    [Benchmark(Description = "Todo Component (DSL) - 10 Items")]
    public void RenderTodoComponentDSL_10Items()
    {
        var cut = _context!.Render<TodoComponentDSL>(parameters => parameters
            .Add(p => p.Items, _items10));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (Razor) - 10 Items")]
    public void RenderTodoComponentRazor_10Items()
    {
        var cut = _context!.Render<TodoComponentRazor>(parameters => parameters
            .Add(p => p.Items, _items10));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (DSL) - 25 Items")]
    public void RenderTodoComponentDSL_25Items()
    {
        var cut = _context!.Render<TodoComponentDSL>(parameters => parameters
            .Add(p => p.Items, _items25));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (Razor) - 25 Items")]
    public void RenderTodoComponentRazor_25Items()
    {
        var cut = _context!.Render<TodoComponentRazor>(parameters => parameters
            .Add(p => p.Items, _items25));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (DSL) - 50 Items")]
    public void RenderTodoComponentDSL_50Items()
    {
        var cut = _context!.Render<TodoComponentDSL>(parameters => parameters
            .Add(p => p.Items, _items50));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (Razor) - 50 Items")]
    public void RenderTodoComponentRazor_50Items()
    {
        var cut = _context!.Render<TodoComponentRazor>(parameters => parameters
            .Add(p => p.Items, _items50));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (DSL) - 100 Items")]
    public void RenderTodoComponentDSL_100Items()
    {
        var cut = _context!.Render<TodoComponentDSL>(parameters => parameters
            .Add(p => p.Items, _items100));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (Razor) - 100 Items")]
    public void RenderTodoComponentRazor_100Items()
    {
        var cut = _context!.Render<TodoComponentRazor>(parameters => parameters
            .Add(p => p.Items, _items100));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (DSL) - 200 Items")]
    public void RenderTodoComponentDSL_200Items()
    {
        var cut = _context!.Render<TodoComponentDSL>(parameters => parameters
            .Add(p => p.Items, _items200));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (Razor) - 200 Items")]
    public void RenderTodoComponentRazor_200Items()
    {
        var cut = _context!.Render<TodoComponentRazor>(parameters => parameters
            .Add(p => p.Items, _items200));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (DSL) - 500 Items")]
    public void RenderTodoComponentDSL_500Items()
    {
        var cut = _context!.Render<TodoComponentDSL>(parameters => parameters
            .Add(p => p.Items, _items500));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (Razor) - 500 Items")]
    public void RenderTodoComponentRazor_500Items()
    {
        var cut = _context!.Render<TodoComponentRazor>(parameters => parameters
            .Add(p => p.Items, _items500));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (DSL) - 1000 Items")]
    public void RenderTodoComponentDSL_1000Items()
    {
        var cut = _context!.Render<TodoComponentDSL>(parameters => parameters
            .Add(p => p.Items, _items1000));
        var markup = cut.Markup;
    }

    [Benchmark(Description = "Todo Component (Razor) - 1000 Items")]
    public void RenderTodoComponentRazor_1000Items()
    {
        var cut = _context!.Render<TodoComponentRazor>(parameters => parameters
            .Add(p => p.Items, _items1000));
        var markup = cut.Markup;
    }

    #endregion
}
