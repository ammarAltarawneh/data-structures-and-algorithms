# Hashmap (repeated-word)

The RepeatedWord method finds the first repeated word in a given input string by using a hash table for efficient tracking.

### Process:

1- It preprocesses the input by removing commas and converting all letters to lowercase for consistent comparison.

2- The method splits the input into words.

3- As it iterates through the words, it checks if each word is already in the hash table.

4- If it finds a word that's already in the hash table, it returns it as the first repeated word and stops processing.

5- If no repeated words are found after checking all words, it returns "nothing repeated."

As a result, this method offers a quick and efficient way to identify the first repeated word in a string.