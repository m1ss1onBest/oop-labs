#include <complex.h>

#include "iostream"

import engine;
import plane;

int main(int argc, char* argv[])
{
    engine some_engine = engine("X-model", 11, 11);
    some_engine.display();
    
    plane::builder plane_builder;

    plane some_plane = plane_builder
    .set_name("Plane name")
    .set_fuel_type("Coal")
    .set_fuel_tank_capacity(150000)
    .set_max_height(9000)
    .set_engine_cylinders(18)
    .set_engine_power(1500).construct();

    some_plane.display();
    return 0;
}
