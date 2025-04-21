# Olympia Farmers' Market - Gift Card Ecosystem

### Developed By:
Blair Palmerlee

<strong>PLEASE NOTE: </strong>This project is a work in progress and does not represent a currently used ecosystem. It is a personal project and was not commitioned by the Olympia Farmers' Market.

## Project Objective

This project aims to solve an observed problem at the Olympia Farmers' Market: Under the current gift card system in place, customers pay the main office for a paper voucher, said voucher is then given to the main office in exchange for wooden coins. The coins are worth one dollar each and vendors may or may not give change when a customer overpays with them. The system is not efficient or customer-friendly. 

The new ecosystem does is not a true POS system, but aims to replace the act of inefficient exchange and reduce the burden of coin management for the customer. 

## The Ecosystem

The ecosystem has three individual applications that all access the same database at different levels.

### Admin Application
The Admin Application is built to remain on a computer in the main office. It has the ability to perform all critical management tasks:

* Add, suspend, and delete other admin accounts.
* Add, suspend, and delete vendor accounts.
* Create gift cards.
* Adjust funds on gift cards.
* View outstanding balances owed to vendors.
* Print gift card QR codes for those without app access.
* View and query a master ledger for all gift card transactions.

### Vendor Application
This application will run on mobile devices and will be accessible only by vendors. Its functions include:

* Processing gift card transactions through scanned QR code.
* Allowing vendors to view and print all of their transactions.
* Showing vendors their owed, outstanding balance.
* Allowing vendors to change their password and contact information.

### Customer Application
The customer facing application is very limitted in database access, as it can be used by anyone. In order to use a gift card on it, a customer must have the card number and a first name to verify ownership. The application is for mobile devices and can do exactly two things:

* View balance and transactions.
* Display a QR code.

For advanced actions like adding funds, purchasing a gift card, or disputing a purchase, the customer will have to contact the main office for administrative action. 

## Admin Application - User Guide

### Login
After opening the Admin Application, a user will be prompted to enter their admin id number and password. Should the user have missing or invalid credentials he or she will be alerted that fact. If the account the user is trying to access is flagged as suspended, a unique prompt will alert the user to this case and instruct them to contact another admin.

### Main Window
After a successful login, the active administrator's number will be kept as the user is navigated to the main window. The window acts as a hub and will terminate the program if closed.

#### Main Ledger
The largest part of the main window is a data grid that gives the user access to the main ledger; the database where all transactions are recorded. As a default, only data from the current month is loaded when first openned or when refreshed. The main ledger can be reloaded at any time by the 'refresh' button in the top right corner.

#### Dynamic Search Bar
The search bar is used for fine-tuned queries of the main ledger. Located next to the 'refresh' button, editting data will filter the results seen on the main ledger. By default the bar is set to look for transaction numbers via entered integers, however there other search criteria can be called as follows:

* ```ven-``` preceding a number searches for transactions by vendor number.
* ```card-``` is similar to the vendor lookup but searches by card number.
* ```yyyy/mm/dd``` searches transactions by date. This one will refine as the user types, starting with the year, then month, then day until the user finds the transaction they're is looking for.
* The search can also look based on transaction type: New Card, Rebalance, Sale.

### Create Gift Card
On the left side of the main window, below the logo is a 'Create Gift Card' button. This button opens a new, smaller window, that prompts an admin to add a first name and amount to add, in order to generate a new card. The ammount cannot be lower then 10 or higher than 2000, but the amount can be altered later. Once the correct information has been entered, a card will be created and window will open allowing the card to be printed, should the customer not have access to the mobile application. 

### Card Accounts
Below the 'Create Gift Card' button is a button labelled: 'Card Accounts.' This button opens a window that allows administrators to query accounts, reprint gift cards, and, most importantly, change the amount on any given chosen card. 

To find a card, the administrator can simply type a card number into the text field. Once a matching card is found, the name and balance on the card will appear. A reprint button is always present, for easy reprinting once a card is selected. 

Next to the card's current balance, a field can be changed in the negative or positive to determine the amount that should be added or taken away from the balance. Once an amount is entered, the small button below the field will change the balance by the entered amount. This change will be reflected immediately in the displayed balance, and will be recorded on the main ledger as a 'Rebalance' and will include the number of the admin who performed it. 

## Vendor Application - User Guide
Not yet in development
//TODO

## Customer Application - User Guide
Not yet in development
//TODO
