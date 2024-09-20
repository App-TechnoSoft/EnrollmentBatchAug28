// OOP: Object Oriented Programming with C#
// C#: Multi Paradigm Language
// Static vs Dynamic
// Procedural vs OOP vs Functional
// Imperative vs Declarative

var student1 = new Student();
student1.name = "Bhawana Rawal";
student1.rollNumber = 34;
student1.dateOfBirth = new DateTime(2000, 12, 12);
student1.PrintDetails();

var student2 = new Student();
student2.name = "James Bond";
student2.rollNumber = 67;
student2.dateOfBirth = new DateTime(1990, 1, 11);
student2.PrintDetails();

// Create two more student objects and print student details in console in following format
// Name     Roll Number  DOB    Gender
// Bhawana Rawal   0       Tuesday, December 12, 2000   F
// James Bond      0       Thursday, January 11, 1990   M

var student3 = new Student();
student3.name = "James Bond";
student3.rollNumber = 67;
student3.dateOfBirth = new DateTime(1990, 1, 11);
student3.PrintDetails();