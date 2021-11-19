# Array-Sort

**** PROBLEM ****

// Write a program that sorts a list of comma separated products.

// Each input row looks like "TITLE,POPULARITY,PRICE". Meaning "Selfie Stick,98,29" says we sold 98 "Selfie Stick"s at 29 dollars each. All numbers are integers. The input will be provided in a hardcoded array so no file I/O is needed.

// The list should be sorted by:

// By most popular first.
// If products are equally popular, sort by cheapest price (lower is better).
// You don't need to write your own sorting algorithm. It's recommended to use a built-in sorting library.

**** SOLUTION ****

Created Item class and ItemComparer Class.
Item class contains title(string), popularity(int), and price(int).
Item Comparer class has enum sortby and Compare function which compares two items by popularity and if the popularity is the same, then order by price.

![Capture](https://user-images.githubusercontent.com/55505154/142551739-99bd47ab-1cbc-4a7c-892a-d9be876fb767.JPG)
