Expect
======

When debugging and supporting real time messaging systems, one first step is usually finding out what the system is waiting for.This requires developers to store system states in discoverable way when developing the system.

The information stored not only needs to be easily discoverable but also needs to be in a format can be understood by support and/or business users. 

This is quite different from logging which developers are usually do. This is because logging records what has happened and here we want to know what needs to happen.

Expect library is trying to provide a generic solution to this problem.

