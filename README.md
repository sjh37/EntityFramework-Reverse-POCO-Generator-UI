# EntityFramework Reverse POCO Generator UI
A simple UI to allow you to easily select which tables you want the EntityFramework Reverse POCO Code First Generator to use.

![](http://www.simonhughes.co.uk/ui_front.png)

* Click the "Connect to Database"
* Tick the tables you want to use in your project. You can also click the links "Select All", or "Select None" to quickly select all or none of the tables.
* The Regex is shown at the bottom of the dialog. This text is *automatically copied to your clipboard*. There is no need to copy this text.
* Change to your Visual Studio project which is using the "EntityFramework Reverse POCO Generator", and overwrite the line *TableFilterInclude = null;* in your database.tt file by pasting (Ctrl-V) with the text from the clipboard.

If the regex text box at the bottom is blank, don't worry, its just that the text box can only display a certain amount of text. The text will still be to the clipboard ready for you to use. However, this is also a warning that you have too many tables in your db context.

Try to keep your db contexts small (< 60 tables).
