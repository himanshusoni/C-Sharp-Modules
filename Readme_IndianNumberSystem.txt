/*
********************** CONVERT NUMBERS TO WORDS W.R.T. INDIAN CURRENCY VERBAL FORMS (Version 0)**********************
*************************************** Author- UJay(jadhav.utkarsh@gmail.com) Date-23 January 2014 *********************
*********************************************************************************************************************
*HOW TO ADD-
*
* Solution Explorer>Right Click>Add> Add Existing Item...>
*
*
*EXAMPLE-
*
* 1) Create object of IndianNumberSystem.
* IndianNumberSystem nu = new IndianNumberSystem();
*
* 2) Methods-
* I) for string without formatting [only one parameter int]
* string str=nu.convertNumToWord(69); output- Sixty-nine
*
* II) for string with prefix rupees[Two parameters int,string]
* string str=nu.convertNumToWord(169,"r"); output- rupees one hundred and sixty-nine
*
* III) for titled string i.e. each starting letter in uppercase[Two parameters int,string]
* string str=nu.convertNumToWord(1169,"t") output - One Thousand One Hundred And Sixty-nine
*
* IV) for slash dash symbol "/-" at the end use "s" in 2nd parameter[Two parameters int,string]
* string str=nu.convertNumToWord(1169,"st") output - One Thousand One Hundred And Sixty-nine/-
*
* V) for suffix "only" after word use "o" in second parameter[Two parameters int,string]
* string str=nu.convertNumToWord(1169,"ost") output - One Thousand One Hundred And Sixty-nine Only/-
*
* VI) using all i.e. "rost"
* string str=nu.convertNumToWord(1169,"rost") output - Rupees One Thousand One Hundred And Sixty-nine Only/-
*
*****************************************************************************************************************
*
*****************************************************************************************************************
*****************In case of bugs, and suggestions, shoot an email on jadhav.utkarsh@gmail.com********************
*
*
*/
