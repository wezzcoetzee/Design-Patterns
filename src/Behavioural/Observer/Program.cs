using Observer;

var appleStock = new Stock("AAPL");

var priceDisplay = new StockPriceDisplay(appleStock);
var priceAlert = new StockPriceAlert(appleStock, 200);

appleStock.SetPrice(150);
appleStock.SetPrice(170);
appleStock.SetPrice(210);