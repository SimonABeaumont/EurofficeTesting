Feature: Search
	As a user on the Euroffice website
	I am able to use the Search feature for products

@Euroffice
Scenario: Search Feature - for valid results
	Given That I have gone to the website
	And I enter the search value 'Pencil'
	And I click the search button
	Then successful product search results are shown

@Euroffice
Scenario: Search Feature - for invalid resuls
	Given That I have gone to the website
	And I enter the search value '+---'
	And I click the search button
	Then unsucessful search message it shown

@Euroffice
Scenario: Compare Search Counts with and without speech marks
	Given That I have gone to the website
	And I enter the search value 'ink cartridges'
	And I click the search button
	Then successful product search results are shown
	And I save the product count results for a search without speech marks
	Then I enter the search value '"ink cartridges"'
	And I click the search button
	And The search without speech marks should return more records than the one with speech marks

#@Euroffice
#Scenario: Check label text above search box

#@Euroffice
#Scenario: Check button text

#@Euroffice
#Scenario: Check text box default text

#@Euroffice
#Scenario: Ensure default text disappears as you enter text in then search text box

#@Euroffice
#Scenario: Test Special characters such as *, %, ?, =, >, <, &, [ (and so ..)  in the search box

#@Euroffice
#Scenario: Test a range of other non  alpha numeric charcters

#@Euroffice
#Scenario: Upper and lower case, effect of search results

#@Euroffice
#Scenario: Test the maximum number of characters the text box can take

#@Euroffice
#Scenario: Click on a search result item and ensure it loads another page correctly

#@Euroffice
#Scenario: Test search result options like AND and OR

#@Euroffice
#Scenario: Search for a unique product name and check only 1 result returned

#@Euroffice
#Scenario: Does the search button work pressing enter and can you tab to it and select it - accessibility

#@Euroffice
#Scenario: Test for suggested results when typing a partial search item

#@Euroffice
#Scenario: Test mouse over event causing button appearance change

#@Euroffice
#Scenario: SQL Injection tests on search text box

#@Euroffice
#Scenario: Copy and paste into the field

#@Euroffice
#Scenario: Cross site scripting - try putting script tags in the search to test effect

#@Euroffice
#Scenario: Not really a separate scenario but a reminder to add multi browser support to
#		   that all tests are run across different browsers

