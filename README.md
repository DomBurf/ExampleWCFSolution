ExampleWCFSolution
==================

This is an example WCF solution that comprises three separate solutions. It is based on a fictitious bailiff (enforcement agency) system.

- A services solution that comprises the WCF services called BailiffServices
- A self-hosting console application called BailiffHost
- A client console application called BailiffClient that consumes the WCF services from BailiffServices.

It is intended to act both as a WCF example project to demonstrate how to build WCF solutions, as well as to provide a WCF template solution for your own WCF projects.

Assumptions
============
It is assumed that you are familiar with the concepts underpinning SOA and WCF and therefore is familiar with the concepts of interfaces and service contracts that are used to define the functionality that they expose. It is also assumed that you are familiar with .NET and C#.

Running the application
=======================
In order to run the application do the following.

Make sure you are running the latest version of the service.
- Open the BailiffService solution in Visual Studio and perform a Rebuild
- Copy the files BusinessTier.dll, Common.dll and DataTier.dll from the BusinessTier\bin\Debug folder and copy them into the BailiffHost\Refences folder

Start the service host.
- Open the BailiffHost solution in Visual Studio
- Press F5 to run the application

The WCF services are now running and ready to be consumed by the client application.

Run the client application.
- Open the BailiffClient solution in Visual Studio
- Ensure you have the latest service references.
- Expand the Service References folder
- Right click on each of the references and select Update Service Reference
- Press F5 to run the application.





