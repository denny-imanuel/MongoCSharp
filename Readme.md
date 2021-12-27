# MongoDB Connector (CSharp)
by Denny Imanuel

This mini project showcase how to connect to Mongo DB using CSharp programming language.
You don't need physical database to test the code. We'll use Docker Compose to create database container.

### Requirement

1. Visual Studio / Rider IDE - You need to install Visual Studio / Rider IDE
2. Docker Desktop - You need to install Docker Desktop for Windows
3. .Net Framework - By default .Net Framework should already installed in Windows

### Run DB Container

First you need to run Mongo DB container and Mongo Express container using following command:

    docker-compose up

Then you can browse Mongo DB via Mongo Express portal at http://localhost:8081

![](jpg/mongo.jpg)

### Test Connector

Finally you can test connection to Mongo DB via following CSharp connector module:

    MongoConnector.cs

