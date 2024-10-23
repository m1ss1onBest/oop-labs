#include <deque>
#include <map>
#include <algorithm>
#include <format>
#include <fstream>

#include "iostream"
#include <string>
// #include <format>

import engine;
import plane;

// struct {
    // bool operator()(plane a, plane b) const
    // {   
        // return a.name1() <b.name1();
    // }   
// } custom_less;

void save_to_file(std::deque<plane>& planes)
{
    std::ofstream file("planes.txt");
    if (!file.is_open())
    {
        throw std::runtime_error("Could not open file");
    }

    for (auto& pl : planes)
    {
        file << pl.format() << '\n';
    }
    file.close();
}

std::deque<plane> load_planes_from_file()
{
    std::deque<plane> planes;
    std::ifstream file("planes.txt");
    if (!file.is_open())
    {
        throw std::runtime_error("Could not open file");
    }

    std::string line;
    while (std::getline(file, line))
    {
        std::cout << "Loaded plane data: " << line << '\n';
    }

    file.close();
    return planes;
}

int main()
{
    plane::builder plane_builder;
    std::deque<plane> planes;

    planes.push_back(plane_builder
        .set_name("Boeing 3310")
        .set_fuel_type("Coal")
        .set_fuel_tank_capacity(150000)
        .set_max_height(9000)
        .set_engine_cylinders(18)
        .set_engine_power(1500)
        .construct());

    planes.push_back(plane_builder
        .set_name("A-10")
        .set_fuel_type("democracy")
        .set_fuel_tank_capacity(123452)
        .set_max_height(6319)
        .set_engine_cylinders(21)
        .set_engine_power(900)
        .construct());

    planes.push_back(plane_builder
        .set_name("F-16")
        .set_fuel_type("rocket fuel")
        .set_fuel_tank_capacity(45000)
        .set_max_height(12000)
        .set_engine_cylinders(45)
        .set_engine_power(6565)
        .construct());

    std::cout << "Before sort" << std::endl;
    for (auto value : planes)
    {
        value.display();
    }


    //sorting
    sort(planes.begin(), planes.end(), [](const plane& plane1, const plane& plane2)
    {
        return plane1.get_name() > plane2.get_name();
    });

    //displaying after sort
    std::cout << "After sort" << std::endl;
    for (auto value : planes)
    {
        value.display();
    }

    //copying deque to map
    std::map<std::string, plane> bTreeMap;
    for (auto plane : planes)
    {
        bTreeMap.insert_or_assign(plane.get_name(), plane);
    }

    //displaying map
    std::cout << "bTreeMap\n";
    for (auto value : bTreeMap)
    {
        std::cout << value.first << "\n";
        value.second.display();
    }
    //sort
    std::sort(planes.begin(), planes.end(), [](const plane& a, const plane& b)
    {
        return (a.get_name() < b.get_name());
    });

    //file

    std::cout << "working with files\n";
    save_to_file(planes);
    auto loaded_from_file = load_planes_from_file();
    
    return 0;
}