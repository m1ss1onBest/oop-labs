module;
#include "iostream"
#include "string"

export module human;
export class human
{
    class brain
    {
        std::string status;

    public:
        brain() : status ("thinking") {}
        brain(std::string status) : status(std::move(status)) {}
    };

    class kidneys
    {
        uint8_t amount;
        std::string status;

    public:
        kidneys() : amount(2), status("new") {}
        kidneys(uint8_t amount, std::string status) : amount(amount), status(std::move(status)) {}
    };

    class lungs
    {
        uint8_t amount;
        std::string status;

    public:
        lungs() : amount(2), status("new") {}
        lungs(uint8_t amount, std::string status) : amount(amount), status(std::move(status)) {}
    };

    std::string name;
    brain h_brain;
    kidneys h_kidneys;
    lungs h_lungs;

public:
    human() : h_brain(brain()), h_kidneys(kidneys()), h_lungs(lungs()) {}
    human(std::string b_status, std::string k_status, std::string l_status, uint8_t k_amount, uint8_t l_amount) :
    h_brain(std::move(b_status)),
    h_kidneys(k_amount, std::move(k_status)),
    h_lungs(l_amount, std::move(l_status))
    {
        
    }
};
