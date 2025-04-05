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
