constructor : is a special method of the class which gets automatically invoked whenever an instace of the class is created
. It is used to assign initial values to the data members of the same class ,
parameter passed as argumemts to the methods 



Types of ctors :: 
 >> default ctor << 
 refer to a ctor that accepts no input arguments , every class in stance must be initialized to the identical values in a dafault ctor 
 the default ctor sets all numveric fields to zero and all string and object field to null within a class 

 << parameterized ctor >>
 refer to a ctor with at least one parameter , it can set different values for each instance of the class
 

 <<copy ctor>>
 by copying variables from another object , this ctor generates an object , 
 its primary purpose is to set the values of a new instance to those of existing one 

 <<private ctor>>
 private ctor is a ctor that is created with private specifier 
 other calsses cannot ingerit from this class , and it is also impossible to create an instance of this class 
 used to pervernt creating instances of a class , 
 when there are on insatnce fields or methods such as the math class 
 or when a method is called to obtain an instance of a class , 
 if alll the methods in the class are static , consider making the complete class static


 <<static ctor>>
 is used to intialize any static data , or to perform a particular action that needs to be performed only once
 it is called automatically before the first instance is created or any static members are refernced

 let's design a game to pratise this!