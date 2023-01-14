// See https://aka.ms/new-console-template for more information

using JarPControlProj.Enity;
using JarPControlProject.PCController.Command;

InvokerOpenClose doer;
PCControl pccontrol = new PCControl("DESKTOP-82BMJ0N");

//OpenProgram method

ComInterfaceOpenClose open = new OpenProgram(pccontrol);

doer = new InvokerOpenClose(open);

doer.doSmth();

//CloseProgram method

ComInterfaceOpenClose close = new CloseProgram(pccontrol);

doer = new InvokerOpenClose(close);

doer.doSmth();

