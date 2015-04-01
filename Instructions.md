#Coding Test

Hey we'd just like to get a basic idea of what you're capable of coding-wise, in a familiar environment that involves a computer instead of asking you to code over the phone or with a marker.

##What to Do
Your goal is to create a Product page for a store website. Depending on your preferences and familiarities, you can approach this one of 2 ways:

A) You can use the files in this zip file, which contains a Visual Studio 2013 Solution (.sln) file and some code to get you started. It requires Visual Studio 2013. The Community Edition is fine, and is free, here:

https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx

B) You can use some other set of tools, whatever you like, whether that be Notepad, Tomato, Sublime, Eclipse, MonoDevelop, older versions of Visual Studio, whatever you like. Just be aware some of this will involve writing db calls to a database of some sort, so if databases aren't your thing, no big deal, but if you want to show off your db skills, you'll need to put some sort of database on your machine (The Visual Studio file uses a built-in one, so there's nothing extra to install).

###Git
The zip file happens to include a git repo. If you're not familiar with git no big deal. If you are feel free to use the git repo to help you with things like revert and, if you feel comfortable, include it in what you send back to us so we can see how you progressed - ideally you'd Commit after each Task below. 

#Tasks
After each of these Tasks, commit your code so we can see how you progressed.

##HTML
Build a static Product page.

In the .sln: `Views\Product\Detail.cshtml`

Add some tags here - don't take too long but enough to make it product page-ish, with a name for the product, cost, description, all in tags that show you're aware of the basics of HTML.

##Paths
Add 2 images to the page:

1. An image you add to the project - download something or add a funny picture, whatever you like, but add it to the Project and then add an img tag that displays the image.
2. An image from the web - add an img tag that displays an image stored elsewhere on the internet.

##Bootstrap
Bootstrap is already included - you can leverage it here to show you know how to use Bootstrap. Maybe the page has a 9-wide content area and 3-wide sidebar, that wrap into a single column on mobile. If you don't know Bootstrap, no big deal.

##CSS
Style the page.

In the .sln: `ui\productdetail.css`

We're more interested in technical competency than prettiness, so show off some selectors or your favorite CSS trick or two. If it comes out looking like a product page that's nice, but, no big deal.

##Javascript and jQuery
Add some events

In the .sln: `ui\productdetail.js`

Add a table to the page with no rows, and a button.

Add a click event to the button, that adds a row to the table.

If you can:

Add a click event that works on the added rows, no matter how many are present on the page.

When the button is clicked, loop over the rows added so far and dump their text contents out, comma-delimited, to the text of the button.

Add the text contents of the rows to a hashtable, then emit just one of them into the text of the button.

##Razor
If you don't know Razor/cshtml, you can skip this.

In the .sln: `Views\Product\Detail.cshtml`

The page has been fed a Model, a Product. Using the `product` variable on the page, render its Name, Cost, and Description somewhere in the HTML you've written.

## `C#`
Modify the Controller feeding the page.

In the .sln: `Controllers\ProductController.cs`

(Note: If you're not using Visual Studio you probably aren't using C# either - try to follow along with the general task in whatever server-side language you chose.)

The current Controller Action ignores the string id argument passed in. Modify it to look for a product by its .Name, case-insensitive, based on the id argument passed to the Action.

This code uses Entity Framework. If you aren't familiar with it you can use SQL instead, by commenting out the `product =...` line and uncommenting the SQL line.

If you can:

Load all Products into a Dictionary in the Action before displaying the page.

Create an array of Hashes of the Products.

Loop over the products using the guts of a foreach - the underlying API calls foreach uses behind the scenes.

#You're Done!
Thanks for taking the test! Zip this all up and send it our way.