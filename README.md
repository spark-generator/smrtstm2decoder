# smrtstm2decoder
A quick and dirty decoder for smrtstm2 files.

## Using
`smrtstm2decoder.exe input.smrtstm2 output.xml`

## Building
You will need to have SmartStim2 installed in the default location and build this project with VS2022.

It references their DLLs to deserialize the binary files into XML. Their underlying code uses an unsafe deserialization method https://aka.ms/binaryformatter and should not be used on smrtstm2 files that you cannot validate.
