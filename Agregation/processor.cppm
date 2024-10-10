module;

#include "iostream"
#include "format"
#include "string"

export module processor;
export class processor
{
    std::string name = "unknown";
    int threads = 2;
    float frequency = 1.56f;

public:
    processor() = default;
    processor(std::string name, int threads, float frequency) :
    name(std::move(name)),
    threads(threads),
    frequency(frequency)
    {
        
    }

    // std::string format()
    // {
        // return std::format("{} processor {} {}hz", name, threads, frequency);
    // }

    // void display()
    // {
        // std::cout << format() + '\n';
    // }
};