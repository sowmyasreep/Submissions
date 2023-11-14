﻿
using System;

using System.Collections.Generic;

using System.Runtime.Remoting;

using System.Runtime.Remoting.Channels;

using System.Runtime.Remoting.Channels.Tcp;

using System.Runtime.Remoting.Lifetime;

namespace RemotingServer

{
    //service class

    public class Service : MarshalByRefObject
    {
        public string SayHello(string s)
        {
            return "Hello" + s;
        }

        public int HighestNumber(int n1, int n2)
        {
            int maxnumber = (Math.Max(n1, n2));
            Console.WriteLine("Remote Call Executed..");
            return maxnumber;
        }
        //managing objects lifetime of either Singleton or ClientActivated objects

        public int SmallestNumber(int n1, int n2)
        {
            int maxnumber = (Math.Min(n1, n2));
            Console.WriteLine("Remote Call Executed..");
            return maxnumber;
        }
        public long MultiplicationNumber(int n1, int n2)
        {
            long mulnumber = (Math.BigMul(n1, n2));
            Console.WriteLine("Remote Call Executed..");
            return mulnumber;
        }
        public  double Remainder(int n1, int n2)
        {
            double rem_value = (Math.IEEERemainder(n1, n2));
            Console.WriteLine("Remote Call Executed..");
            return rem_value;
        }
        public override object InitializeLifetimeService()
        {
            ILease lease = (ILease)base.InitializeLifetimeService();
            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(25);
                lease.SponsorshipTimeout = TimeSpan.FromSeconds(25);
                lease.RenewOnCallTime = TimeSpan.FromSeconds(25);
            }
            return lease;
        }

    }

    //server class

    //it hosts the services by registering them

    class Server

    {

        static void Main(string[] args)

        {


            TcpChannel tcpchannel = new TcpChannel(9050);

            //register the channel

            ChannelServices.RegisterChannel(tcpchannel, false);

            //configure all known services

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "OurFirstRemoteService",

              WellKnownObjectMode.Singleton);

            Console.WriteLine("Server Services started on tcp Port No: 9050...");

            Console.WriteLine("Press any Key to Stop the Server Services..");

            Console.ReadLine();

        }

    }

}