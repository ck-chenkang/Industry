# PPI MPI Profibus-DP Modbus 

[Difference between PPI, MPI and Profibus](https://support.industry.siemens.com/tf/ww/en/posts/difference-between-ppi-mpi-and-profibus/175729)

All 3 are protocols that are used to communicate with and between Siemens S7 CPUs; they are all built on the RS 485 standard, so they al share some basic features; 32 nodes in a (copper wire) segment, one master (at least) and up to 31 slaves in the segment, the capacity to have HMI/SCADA systems as nodes in the bus, ....

PPI (Point-to-point interface protocol)is restricted to communications and programming of the S7-200 family CPUs. Max. speed is 9600 baud, exchanges are programmed and configured in S7-microWin, the programming software for the S7-200. You will find descriptions and examples of PPI networks in the following document:

[S7-200 System Manual](https://support.industry.siemens.com/cs/document/1109582/s7-200-system-manual?lc=en-FR)

MPI (Multi-point interfcae protocol) is used as a programming protocol for the S7-300 and S7-400 PLCs, and allows connections between CPUs. Its max. speed is 187,5 kBaud, It uses a sub-set of Profibus-DP instructions to exchange data between the CPUs. A s7-200 can also act as a slave to a S7-300/400 master on a MPI connection.

https://support.industry.siemens.com/tf/fr/en/posts/ppi-mpi-what-are-the-real-differences/14517/?page=0&pageSize=10

Profibus-DP also uses the RS-485 standard as a basis, but can go up to speeds of 12 MB, so it is designed for fast master-slave data exchange over the network. Slaves can include sensors, motors, drives, from many manufacturers, so there is a need for a standard configuration tool; this is called the gsd file. There are 2 types of masters defined in the standard: Masters Class 1 hold a very strict configuration and address the slaves in their configuration very fast and cyclically (these are generally PLCs or other controllers); Masters class 2 wait for the Profibus token to be transfered to them so they can interrogate exiting masters or slaves  to get the required information (these are HMIs, SCADA systems...).

A S7-400/300 can act either as a master or a slave on Profibus-DP, on its own integrated DP port, or ith a CP 342-5 profibus communication module.A S7-200 can be a ProfibusDP slave to any DP-master, if it is configured with a EM 277 Profibus slave module.

Profibus-DP is maintained by an independant software group, Profibus International. You can find a lot of documentation there (the PI site is Profibus.com), such as this document:

[Profibus system Description](http://www.profibus.com/nc/download/technical-descriptions-books/downloads/profibus-technology-and-application-system-description/download/21420/)