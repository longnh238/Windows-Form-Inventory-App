# **Inventory App**

This repository contains a simple inventory management application built using Windows Forms in C#. The app allows users to create items with a unique ID and manage their inventory by updating quantities for received and issued items.

## **Table of Contents**
- [Overview](#overview)
- [Features](#features)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)

## **Overview**
The **Inventory App** is a basic inventory management system designed to handle items' quantity tracking. It provides functionalities for creating an item, receiving stock, issuing stock, and validating inventory updates. 

The app ensures the quantity values are valid and notifies users when there are input errors, like issuing more than available stock.

## **Features**
- **Create Item**: Generates an item with a unique ID and initial quantity.
- **Update Item**: Allows users to update the inventory by receiving or issuing stock.
- **Validation**: Ensures valid inputs for item quantities.
- **Dynamic UI**: Shows or hides relevant fields based on the current action (create or update).

## **Requirements**
- Windows OS
- .NET Framework 4.7+
- Visual Studio (or any compatible IDE for Windows Forms development)

## **Installation**
1. Clone the repository:
   `git clone https://github.com/your-username/ln-inventory-app.git`

2. Open the solution in Visual Studio:
   `cd ln-inventory-app`

3. Build and run the application.

## **Usage**
1. Launch the application.
2. Enter the item name and quantity to create a new item.
3. Once an item is created, you can receive or issue stock, and the app will update the item's total quantity accordingly.
4. The app validates the input to ensure no negative stock quantities are allowed.

## **Contributing**
Feel free to contribute to this project by submitting issues or pull requests. Contributions for improving the UI, enhancing features, or fixing bugs are welcome.
