This is an automation using c# selenium with Reqnroll framework. This demonstrate UI Automation with BDD format.
The structure of this is as follow
* Feature file - this contains the readable format of test cases which non developers can understand. It contains the scenario and the steps that is intended for the automation
* Step definition - this contains the definitions that is on the feature file, this calls the classes or methods for each equivalent words on the feature file
* Pages - this contains the selenium codes for the step definition file, you can view here all the xpath, methods and etc that is used by the step definitions.
* Hooks - this class contains the before or after scenario, tags etc. You can set the behavior here depending on the needs

To run this kindly clone the solution and make sure of the following is installed
* Reqnroll for Visual Studio - to install this go to Extensions > Manage Extensions then search for the said extension. Latest version should be installed
  ![image](https://github.com/user-attachments/assets/3a3999b6-caa1-4324-9c5f-f8993caa5148)

* Nuget packages - to install right click on the solution > Manage Nuget packages
1. Selenium
2. NUnit3TestAdapter
3. NUnit
4. Microsoft.Net.Test.SDK
![image](https://github.com/user-attachments/assets/b7f33dfa-de84-4a62-8307-ec10e1ae3389)

NOTE
- Specflow was recently discontinued and removed to MS Store. Reqnroll was created to replace Specflow, a bit of a learning curve is needed because not all extensions are the same and will need more time to study them.
- Few test were only created since we are giving a sample of expectations to accomplish given a specific amount of time. This includes the creation of the framework and a learning curve for the replacement of specflow
