### Background:

* A barcode is a string of text.  
* A barcode text consists of fields that are sub-strings within the barcode text.  
* Barcode fields are organised by a pre-defined rule called specification, which stipulates. 
 * the position
 * data type, and
 * length of each field
* Each field has a unique name as its identity.
* There are many different specifications, representing different barcodes in our industry. E.g.,  
 * Boarding Pass barcode
 * MRZ barcode
 * etc.

### Requirement:

Given that we have 3 known barcode specification, design a system that is capable of parsing a barcode in any of the 3 specifications.  
It is believed that barcode specification evolves and grows very fast. Design a system that can parse a barcode by future specification that yet known today.

**_Assumption_**: _when parsing a barcode, the barcode specification is known._