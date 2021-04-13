﻿using CreationPatterns._2__Factory_Method.Example_1.Interface;
using CreationPatterns._2__Factory_Method.Example_1.Vehicles;

namespace CreationPatterns._2__Factory_Method.Example_1.Factories
{
    class BikeTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Bike();
        }
    }
}
