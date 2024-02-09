# All Star Code Challenge #18

Create a function that accepts a string and a single character, and returns an integer of the count of occurrences the
2nd argument is found in the first one.

If no occurrences can be found, a count of 0 should be returned.

_("Hello", "o")  ==>  1_ \
_("Hello", "l")  ==>  2_ \
_("", "z")       ==>  0_ 

_str_count("Hello", 'o'); // returns 1_ \
_str_count("Hello", 'l'); // returns 2_ \
_str_count("", 'z'); // returns 0_ 

## Notes:

+ The first argument can be an empty string
+  In languages with no distinct character data type, the second argument will be a string of length 1