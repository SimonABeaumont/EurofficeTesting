Feature: Search
	As a user on the EuroOffice website
	I am able to use the Search feature for products

@EuroOffice
Scenario: Search Feature - for valid results
	Given That I have gone to the website
	And I enter the search value 'Pencil'
	And I click the search button
	Then successful product search results are shown

@EuroOffice
Scenario: Search Feature - for invalid resuls
	Given That I have gone to the website
	And I enter the search value '+---'
	And I click the search button
	Then unsucessful search message it shown

@EuroOffice
Scenario: Compare Search Counts with and without speech marks
	Given That I have gone to the website
	And I enter the search value 'ink cartridges'
	And I click the search button
	Then successful product search results are shown
	And I save the product count results for a search without speech marks
	Then I enter the search value '"ink cartridges"'
	And I click the search button
	And The search without speech marks should return more records than the one with speech marks

#@EuroOffice
#Scenario: Check label text above search box

#@EuroOffice
#Scenario: Check button text

#@EuroOffice
#Scenario: Check text box default text

#@EuroOffice
#Scenario: Ensure default text disappears as you enter text in then search text box

#@EuroOffice
#Scenario: Test Special characters such as *, %, ?, =, >, <, &, [ (and so ..)  in the search box

#@EuroOffice
#Scenario: Test a range of other non  alpha numeric charcters

#@EuroOffice
#Scenario: Upper and lower case, effect of search results

#@EuroOffice
#Scenario: Test the maximum number of characters the text box can take

#@EuroOffice
#Scenario: Click on a search result item and ensure it loads another page correctly

#@EuroOffice
#Scenario: Test search result options like AND and OR

#@EuroOffice
#Scenario: Search for a unique product name and check only 1 result returned

#@EuroOffice
#Scenario: Does the search button work pressing enter and can you tab to it and select it - accessibility

#@EuroOffice
#Scenario: Test for suggested results when typing a partial search item

#@EuroOffice
#Scenario: Test mouse over event causing button appearance change

#@EuroOffice
#Scenario: SQL Injection tests on search text box

#@EuroOffice
#Scenario: Copy and paste into the field

#@EuroOffice
#Scenario: Cross site scripting - try putting script tags in the search to test effect

#@EuroOffice
#Scenario: Not really a separate scenario but a reminder to add multi browser support to
#		   that all tests are run across different browsers

