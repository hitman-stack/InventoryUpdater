# InventoryUpdater
Gartner Coding Assignment:## SaaS Products Import

We update our inventory of SaaS products from several sources.  Each source provides its content to us in a different format.  Write a command line script to import the products.

Input/output should be something like this:
 
````bash
$ import capterra feed-products/capterra.yaml

importing: Name: "GitHub";  Categories: Bugs & Issue Tracking, Development Tools; Twitter: @github
importing: Name: "Slack"; Categories: Instant Messaging & Chat, Web Collaboration, Productivity; Twitter: @slackhq
````

Considerations:
- Currently, we are importing products from 2 sites: capterra and softwareadvice.  They send us their weekly feed via email.  This weeks files are in /feed-products
- We plan to add a third provider soon who will make their feed available via csv output online via a url (you don't need to implement this, just keep it mind)
- Do not implement any data persistence code, just provide some dummy classes that echo what they are doing.  Keep in mind that the company is planning to switch from MySQL to MongoDB in 3 months.
- The focus here should be on design, more than implementation.  We are less interested in seeing that this works than in seeing how you approach the problem.
- Please provide at least some unit tests (it is not required to write them for every class). Functional tests are also a plus.
- Please provide a short summary detailing anything you think is relevant, for example:
  - Installation steps
  	Install Visual Studio
	Target Framework is .NetCore 3.1 so make sure you have that	
  - How to run your code / tests  
  	-Open project in Visual studio code 
  	-Clean solution and Build again
  	-Pass the path for both the file in InventoryUpdater\InventoryUpdater\Shared\Constants.cs
 	- For running the test just go to test and run all tests
  - Where to find your code
  	https://github.com/hitman-stack/InventoryUpdater
  - Was it your first time writing a unit test, using a particular framework, etc?
  	- No, I am using NUnit in my current project to write test cases
  - What would you have done differently if you had had more time
  	- I would have written more test cases.
	- Instead of reading the path from hardcoded path would have done something differently to get it directly
	- More validations 
	- Some datatabase methods
 
* * * 

## Code Submission

As a result of this assignment we expect to recieve a link to your shared git repository (i.e. Bitbucket or Gitlab offer free private repos).
Having full commit history is optional but would be considered as a plus.


## How I am planning to approach this problem :
- Have somefolder like:
### Data acccess: All database logic will reside here(database connection and manupulation)
### Infrastructure: Business logic will reside here 
### Orchestrature: Will act like abstraction layer to hide the implementation
### Shared: Will have some shared methods and constants
	Utils: All shared methods which can be used for multiple projects
	Constants: Message or any other constants can be define here
### Domain: Models and interface which are to implemented can be define here
### Two factories one fore datareader and other for database sorce
### One test solution to write unit test cases
