# IS (Information Security)
Information security is a fundamental concern in the digital age, where data is a valuable and ubiquitous resource. It aims to protect the confidentiality, integrity and availability of data against threats and cyber attacks. This involves implementing appropriate policies and technologies to prevent unauthorized access to sensitive information, ensure that data remains unaltered and is available when needed. Hands-on labs in information security provide the opportunity for participants to understand and experience techniques and tools used to protect and assess the security of systems and data, thus contributing to the development of a safer and more threat-resistant digital environment.

## Laboratory 1 - The Unix Password Based Authentication System
The lab consists of a detailed analysis of the password-based authentication system in the Unix environment. Analysis of the password-based authentication system in Unix reveals a robust structure, but not without vulnerabilities. Its foundation is based on the /etc/passwd file, which stores information about users, including encrypted passwords. However, in modern systems this was replaced by /etc/shadow to improve security, as /etc/passwd was accessible to all users. Additionally, the password encryption algorithm (typically MD5, SHA-256, or SHA-512) is a crucial component of the authentication system. However, attack methods such as brute force attacks or the use of weak passwords remain a major concern. Also, proper management of access rights and strong password policies are essential to protect the system from compromise. Therefore, the analysis of this system emphasizes the need for a comprehensive approach to ensure the security and integrity of authentication in the Unix environment.

## Laboratory 2 - Symmetric Encryption in .NET
The Symmetric Encryption in .NET Lab is an interactive experience that explores various encryption algorithms, including DES, 3DES, and Rijndael. In this lab, a customized program is created in which they can choose the desired encryption algorithm and generate the key and the initial vector. Through an intuitive interface, users can enter text in ASCII format and, by pressing the "Encrypt" button, the text is encrypted and presented in HEX format. For decryption, users can use the corresponding button, generating the decrypted text in both ASCII and HEX format. Furthermore, the lab provides the functionality to measure the time required to encrypt and decrypt a block message, thus providing insight into the performance of encryption algorithms in real time. This hands-on experience gives participants a deeper understanding of symmetric encryption concepts and their impact on processing time.

![picture alt](https://github.com/victorcb0/IS/blob/main/Laborator%202/Laborator%202.png)

## Laboratory 3 - Hash Functions and MAC Codes in .NET
The Hash Functions and MAC Codes in .NET lab explores various hashing algorithms, including SHA1, MD5, RIPEMD, SHA256, SHA384, and SHA512. Through a custom program created within this lab, users can select their desired hash algorithm and receive automatic random key generation upon program initialization. Using text entered into a text field, users can then press the "Compute MAC" button to generate the associated MAC code, presented in both ASCII and HEX format. The function of the "Verify MAC" button is to verify the correspondence between the generated MAC and the one entered in HEX format, thus providing an effective way to verify data integrity. This lab provides valuable hands-on experience in understanding and applying the concepts of hashes and MAC codes in the context of cybersecurity and data protection.

![picture alt](https://github.com/victorcb0/IS/blob/main/Laborator%203/Laborator%203.png)

## Laboratory 5 - The RSA Public-Key Cryptosystem in .NET
The RSA Public Key Cryptography Lab in .NET provides an experience in using and understanding this cryptographic algorithm. Within this lab, several distinct programs were developed, including encrypting an AES key with RSA, signing and verifying with RSA, and calculating the time required for various RSA operations such as key generation, encryption, decryption, signing, and verification . The performance of these operations was observed and analyzed in real time. In addition, the lab also included signing and verification functionality with the DSA algorithm, providing a broad insight into the various cryptographic options available in .NET. The parameters and results were displayed in the form of XML, making them easy to understand and interpret. Through this experience, a deeper understanding of the use and practical implications of the RSA algorithm and digital signature in the field of cyber security was gained.

## Laboratory 6 - Computational Problems Behind Public-Key Cryptosystems, BigIntegers In Java
The lab on the computational problems behind public-key cryptosystems, BigIntegers in Java, provided the opportunity to explore and better understand key concepts in modern cryptography. Among the problems studied was the mathematical relationship between the private and public RSA exponents, which was essential to understand the working mechanism of this cryptosystem. It also discussed the importance of using small encryption exponents in the context of security and performance of RSA operations, highlighting the risks associated with using small exponents, such as vulnerability to brute force attacks. In addition, through a program created in Java, a challenge was made to find the factorization of a given modulus in a set of RSA keys, which demonstrated the computational difficulty of this problem and the need to use efficient algorithms to solve it such challenges. Through this lab, a deeper understanding of the theoretical and practical aspects of public key cryptography was gained, as well as the skills needed to approach and solve computational problems specific to this domain.

## Laboratory 7 - Cryptography in Java: Symmetric and Asymmetric Encryptions, Password Based Key-derivations
The lab on cryptography in Java provided hands-on experience in using and understanding various encryption techniques and algorithms, both symmetric and asymmetric, as well as derivation of password-based keys. Among the programs created were examples of AES and RSA encryption and decryption in Java, thus providing a deeper understanding of the implementation of these algorithms in a specific programming environment. Also explored are examples of password-based key derivation for AES, using HMACSHA1 for key generation and a specific number of iterations for increased security. Another program involved encryption in CBC, OFB, and CFB modes of operation, using a key generated from the user's password and ensuring that the initialization vectors were set correctly. Additionally, another example consisted of deriving keys from passwords, and the computational time required to generate the password was measured and displayed. Through this lab, practical knowledge and skills were gained in implementing and using cryptography in Java applications, strengthening the understanding of essential cryptographic concepts.

## Laboratory 10 - Environment Variable and Set-UID Program
The Environment Variable and Set-UID Program lab is an opportunity for deep understanding of how environment variables and Set-UID programs influence the operation and security of operating systems. In this lab, various aspects related to the manipulation of environment variables, their transmission between processes, interaction with system functions and their use in privileged programs are explored. By approaching the bulleted tasks, they will gain a thorough understanding of the impact and risks associated with the use of environment variables and Set-UID programs in modern computing environments.

Tasks:
1. Manipulating Environment Variables
2. Passing Environment Variables from Parent Process to Child Process
3. Environment Variables and execve()
4. Environment Variables and system()
5. Environment Variable and Set-UID Programs
6. The PATH Environment Variable and Set-UID Programs
7. The LD PRELOAD Environment Variable and Set-UID Programs
8. Invoking External Programs Using system() versus execve()
9. Capability Leaking

Sample image from the report (task 9):

![picture alt](https://github.com/victorcb0/IS/blob/main/Laborator%2010/Task%209.png)

## Laboratory 11 - Buffer Overflow Vulnerability Lab
The Buffer Overflow Vulnerability Lab is an essential exercise in understanding the security vulnerabilities associated with buffer overflows in software applications. This vulnerability is one of the most common and dangerous in programming because it can be exploited to compromise a system's security and execute malicious code. In this lab, participants will explore various aspects of buffer overflow, such as running shellcode, exploiting the vulnerability, defeating countermeasures such as randomized addresses or StackGuard Protection, and enabling non-executable stack protection. By tackling these bulleted tasks, one acquires practical knowledge and essential skills in cyber security, understanding how to protect against these threats and how to identify and remediate such vulnerabilities in their applications.

Tasks:
1. Running Shellcode
2. Exploiting the Vulnerability
3. Defeating dash’s Countermeasure
4. Defeating Address Randomization
5. Turn on the StackGuard Protection
6. Turn on the Non-executable Stack Protection

Sample image from the report (task 6):

![picture alt](https://github.com/victorcb0/IS/blob/main/Laborator%2011/Task%206.png)

## Laboratory 12 - Return-to-libc Attack Lab
The Return-to-libc Attack Lab introduces the field of cybersecurity, focusing on exploring and understanding Return-to-libc attacks. This technique, used in exploiting buffer overflow vulnerabilities, allows an attacker to take control of program execution and execute malicious code. In this laboratory, they are guided through a series of practical tasks, which cover various aspects of this type of attack. From identifying the addresses of libc functions in memory, to effectively exploiting buffer overflow vulnerabilities and overcoming security countermeasures, the lab provides comprehensive experience in identifying and remediating security vulnerabilities in software applications. By tackling these tasks, participants develop practical skills and strengthen their understanding of key concepts in the field of cyber security.

Tasks:
1. Finding out the addresses of libc functions
2. Putting the shell string in the memory
3. Exploiting the buffer-overflow vulnerability
4. Turning on address randomization
5. Defeat Shell’s countermeasure

Sample image from the report (task 5):

![picture alt](https://github.com/victorcb0/IS/blob/main/Laborator%2012/Task%205.png)
