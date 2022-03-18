using OwnInputOutputDecorator.Abstractions;
using OwnInputOutputDecorator.Implements.Decorators;
using OwnInputOutputDecorator.Implements.Inputs;

string input = "HeadFirst Design Patterns book is very awsome";

InputStream buttonInputStream = new ButtonInputStream(input);

buttonInputStream = new LowerCaseInputStream(buttonInputStream);
buttonInputStream = new DoubleQoutesInputStream(buttonInputStream);
buttonInputStream = new DoubleQoutesInputStream(buttonInputStream);
//buttonInputStream = new UpperCaseInputStream(buttonInputStream); // see this if you want it ;)

buttonInputStream.Write();