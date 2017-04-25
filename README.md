# Party Planner
[Head First C#](http://www.headfirstlabs.com/books//hfcsharp/)

&nbsp;
## 00 Start the project
* In VS, create a Windows Forms Application project.

&nbsp;
## 01 Configure the form
* Set name, text, icon etc.
* Turn off the minimize box and maximize box.
* Add the labels, numericUpDown and checkboxes controls.

&nbsp;
## 02 Create the *DinnerParty* class
* Create the *DinnerParty* class.
* Add the public properties. These properties are set in the constructor and updated by the form, and they're used when calculating the cost.
* Add the constructor. It sets the three properties based on the values passed into it by the form.

&nbsp;
## 03 Create private methods to calculate the intermediate costs
* In the *DinnerParty* class create the *CalculateCostOfDecorations* and *CalculateCostOfBeveragesPerPerson* private methods.

&nbsp;
## 04 Add the read-only Cost property to calculate the cost
* Add a read-only property called *Cost* that calculates the cost of the dinner party. The calculations are private and encapsulated behind the Cost property.

&nbsp;
## 05 Update the form to use the properties
* Use the constructor and the three properties(NumberOfPeople, FancyDecoration, and HealthyOption) to pass information into the object, and the Cost property to calculate the cost.
* The *DisplayDinnerPartyCost* method updates the dinner party cost on the form by accessing the
Cost property every time it updates the form.

&nbsp;
## 06 Add a tab control
* Add a tab control, set a tab for the dinner party and another for a birthday party version.
* Copy the dinner party controls to the first tab and adjust the existing code.

&nbsp;
## 07 Add the *BirthdayParty* class
* Create the *BirthdayParty* class.
* Add the public properties. These properties are set in the constructor and updated by the form, and they're used when calculating the cost.
* Add the constructor. It sets the three properties based on the values passed into it by the form.

&nbsp;
## 08 Add private properties to the *BirthdayParty* class
* Add the required private properties to the *BirthdayParty* class.

&nbsp;
## 09 Add public properties to the *BirthdayParty* class
* Add the *CalculateCostOfDecorations* private method, same as in *DinnerParty*.
* Add the required public properties to the *BirthdayParty* class. These are *CakeWritingTooLong* and *Cost*.

&nbsp;
## 10 Configure the *BirthdayParty* form UI
* Add the labels, numericUpDown, checkbox and textbox controls.

&nbsp;
## 11 Update the form to use the properties
* Use the constructor and the properties to pass information into the object, and the Cost property to calculate the cost.
* Use the Events page in the Properties window to add a new TextChanged event handler to the cakeWriting TextBox.
* The *DisplayBirthdayPartyCost* method updates the dinner party cost on the form by accessing the
Cost property every time it updates the form. Also displays the *tooLongLabel* if the *CakeWriting* message string is too long.

&nbsp;
## 12 Add the *Party* base class.
* Create the *Party* base class which contains the common elements of the two existing classes.
* Edit the virtual version of the Cost property to contain the common elements for both cases. Include the extra fee if there are more than 12 people in the party.

&nbsp;
## 13 Edit the *BirthdayParty* class to inherit from *Party*
* The BirthdayParty constructor stays the same, even though it sets properties that are in the base class.
* Edit the override version of the Cost property to contain the extended elements for BirthdayParty. It calls `base.Cost` from Party to include the inherited elements.

&nbsp;
## 14 Edit the *DinnerParty* class to inherit from *Party*
* The DinnerParty constructor stays the same, even though it sets properties that are in the base class.
* Edit the override version of the Cost property to contain the extended elements for DinnerParty. It calls `base.Cost` from Party to include the inherited elements.
