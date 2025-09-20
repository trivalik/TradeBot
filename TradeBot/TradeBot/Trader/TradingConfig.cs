namespace TradeBot.Trader;

public class TradingConfig
{
    public string Symbol { get; set; } = "BTCUSDT";
    public decimal OrderSize { get; set; } = 10m; // order size in USDT
    public int PeriodMinutes { get; set; } = 15; // period for analysis
    public int AnalysisPeriods { get; set; } = 20; // number of periods for analysis
    public decimal SidewaysThreshold { get; set; } = 0.02m; // threshold for determining lateral movement (2%)

    // Parameters for a sideways trading strategy
    public decimal BuyDistanceFromSupport { get; set; } = 0.005m; // distance from support for purchase (0.5%)
    public decimal SellDistanceFromResistance { get; set; } = 0.005m; // distance from resistance for sale (0.5%)
    public decimal MinProfitPercent { get; set; } = 0.003m; // minimum profit for closing a position (0.3%)
    public int MaxPositionHoldHours { get; set; } = 24; // maximum position holding time in hours
    
    // Obsolete parameters - no longer used
    [Obsolete("Используйте MinProfitPercent вместо TakeProfitPercent")]
    public decimal TakeProfitPercent { get; set; } = 0.5m;
    [Obsolete("Стоп-лосс не используется в данной стратегии")]
    public decimal StopLossPercent { get; set; } = 0.3m;
}