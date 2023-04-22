using Composite;

// Create menu components
var breakfastMenu = new Menu("Breakfast Menu", "Breakfast items");
var lunchMenu = new Menu("Lunch Menu", "Lunch items");
var dinnerMenu = new Menu("Dinner Menu", "Dinner items");
var dessertMenu = new Menu("Dessert Menu", "Dessert items");

// Add individual menu items
breakfastMenu.Add(new MenuItem("Pancakes", "Fluffy pancakes", 5.99));
lunchMenu.Add(new MenuItem("Hamburger", "Juicy hamburger", 7.99));
dinnerMenu.Add(new MenuItem("Steak", "Grilled steak", 12.99));
dessertMenu.Add(new MenuItem("Ice Cream", "Vanilla ice cream", 2.99));

// Create the main menu and add submenus
var mainMenu = new Menu("Main Menu", "All available menus");
mainMenu.Add(breakfastMenu);
mainMenu.Add(lunchMenu);
mainMenu.Add(dinnerMenu);
mainMenu.Add(dessertMenu);

// Print the main menu and its components
mainMenu.Print();