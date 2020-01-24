C# TRAINING ESSENTIALS PART 1:
SYNTAX & OBJECT-ORIENTED PROGRAMMING

A. History of C#
 - Started out with project code name “Cool”, “C-Like Object Oriented Programming”.
 - Released in 2000 alongside .NET framework.
 - It can be used to write software that runs in almost any environment.
 - Wanted it to accomplish:
    - Type checking
    - Array bounce checking
    - Detection of uninitialized variables
    - Automatic garbage collection
 - Designed to be used in deployment to distributed environments.
 - Compatible with both hosted && embedded systems, supporting large operating systems down to small dedicated functions.
 - Core language consists of **80 key words**.
 - C# can run on all mobile devices at roughly the same efficiency as native languages / frameworks.

B. .NET Framework & Runtime
 - Used to build and deploy web applications (similar to Rails for Ruby)
 - C# is not the only language that can be used with .NET - almost every major language that exists can be used with it. 
 - Framework Class Library (FCL)
    - This includes pre-built components that you can use in personal applications
    - This should be checked with 3rd-party packages to optimize application build time
    - FCL provides the ability to build software 
 - Common Language Runtime (CLR)
    - CLR focuses on what is needed to run the code - HOW OUR CODE EXECUTES
    - Provides a virtual machine 
        - Code written in .NET languages are not compiled to machine code but is compiled to an intermediary format called bytecode
        - Bytecode is then compiled at runtime on the platform in a process called Just-In-Time (JIT) ---> security, memory management, exception handling
    - As the program runs code, objects are created, used, and then passed outside of scope by a garbage collection process, freeing up memory / resources 
        - Allocate, then deallocate memory 

C. Getting Started w/ C#

