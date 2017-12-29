
This ASP.NET MVC application is developed using Visual Studio 2012 Community edition on windows-7 Machine. 
To Run the project open it in Visual studio 2012 or above and run in google chrome. Click the provided html button which will render the records as directed using AJAX calls. All the order objects are placed under the Model folder in the project. Base abstract class OrderBaseClass was the implementation of the interface IOrderBase. All the other order types (Paramed, Criminal Report, Credit Check) were implemented using this OrderBaseClass.

New changes as per the latest Class diagram provided are as below.

-change all properties in OrderBaseClass to private and create getter setters for the same.
- change AddService(Service serviceIn) method to  AddService()
-change data types in orderbaseclass
		orderid:int
		customernumber: int
		ordertype: string
	   services:list<service>
	   servicecount:int
-change interface 
	-add below properties in interface
		orderId: int
		customernumber:int
		accountnumber:int
		orderType:string
		services:list<Service>
-add ordertype property  in order base class
-add servicecount  property in order base class