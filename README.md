# RSG
The [Random String Generator project](https://reap.myportfolio.com/random-string-generator) released in 2016.

# Backstory
The random string generator was created to fufill my needs in aiding me generating quick, random passwords using random strings. The secondary feature was to modestly describe the entropy of the password using a univariate analysis of entropy, which is the _permutations_ of that string combination using the `character set length ^ string length`. The _probability_ would be `1 / character set length ^ string length`. Although, a univariate analysis isn't solid grounds for determining entropy in a string, it is an extremely quick indicator of it given that you analyze the complexity of the string next to that number.

# Is Entropy Important?
Entropy in our context describes the amount of predictibility in a string. The more predictable, the easier to crack (hack) the string, subsequently, hacking you by gaining access to parts of your login credentials which encapsulates your authority to access parts of the internet. Getting hacked is not fun, and can leave you at risk to many things depending on the site and what the hacker has access to. In order to reduce this risk, we essentially want to generate high entropy strings in passwords so that password cracking algorithms are rendered useless. You want high amounts of entropy in your passwords or in creating encrypted string and hashes. In other words, you want maximum randomness in the string. This describes a lack of order, a lack of predictibility, ultimately, leaving you with maximizing randomness.

# Univarite Analysis for Calculating Entropy
The method I use to determine entropy is just a starting point. There are a lot more variables in calculating entropy precisely, however, using the calculation above, coupled with the ability to see the random generated string itself, allows you to make a quick judgement about whether the random string has high entropy.

# Other Variables in Calculating Entropy
This is not a complete list, but in the context of determining the amount of randomness in a string of just english letters. Here is a list with some explanation
* **Repeating characters**: e.g. string A: `aaaaa` vs. string B: `zqnge`, a is repeated five times, making it much more predictable, and less random than string B. In general, if no character repeats in the string, it is generally considered to have high entropy as long as the other variables in the list arent also validated.
* **Linguistically recognizable**: e.g. string A: `homes` vs. string B: `aaaaa`, A is recognized because it is a word in the English language
* **Bruteforcable**: If iterating through every possible combination of the string, will a computer be able to do it in a timespan that is worthy of the task? e.g. string A: `aaaaabbbbbcccccddddd` vs string B: `IZQRHTZMKHKCYTGUOCOX`

# What this project means to me 
This code is extremely old, and encompasses my early desire for creating applications at a young age. Development began in 2013, and went through several design and code iterations. I've decided to bring it to GitHub. Demonstrates my coding ability without following any good practices at all for software development. This project was fully responsible for fundamentally changing the way I pursued software development and was the my spark that really made me want to develop as a career. It is also responsible for the way I think about features and just passionate about making something happen.



Features: Ability to generate any string with any character set in unicode.
- Ability to create and generate dictionarys that will be used to generate random words of any length
- Compute permutations of *any set* in actual figures.
- Export any number of iterations to a text file
- Statistics for many of the screens
- and a ton more.

Images from [Iconfinder](https://www.iconfinder.com/)

[Download latest release](https://github.com/Reapism/RSG/releases)

[See my portfolio](https://reap.myportfolio.com/random-string-generator)
