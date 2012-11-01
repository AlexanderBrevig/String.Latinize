String.Latinize
===============

Make any unicode string conform to [a..zA..Z], keep whitespace and symbols/numbers

Install using Package Manager Console: 

    PM> Install-Package Latinize

Example:
	
    //using Latinize;
	Console.WriteLine("äæåâáàãÄÆÅÂÁÀÃ çÇ éèêëeÉÈÊËE øöØÖ".Latinize());
	//=>               aaaaaaaAAAAAAA cC eeeeeEEEEE ooOO
