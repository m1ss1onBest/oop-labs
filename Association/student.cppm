module;
#include <iostream>
#include <format>
#include <string>

export module student;
export class student  // NOLINT(cppcoreguidelines-special-member-functions)
{
    std::string first_name;
    std::string last_name;
    std::string email;

public:
    student()
    {
        first_name = last_name = email = "";
        std::cout << "created empty student at: " << this << '\n';
    }
    
    student(std::string first_name, std::string last_name, std::string email) :
    first_name(std::move(first_name)),
    last_name(std::move(last_name)),
    email(std::move(email))
    {
        std::cout << "new student created at: " << this << '\n';
    }

    student(const student& original) :
    first_name(original.first_name),
    last_name(original.last_name),
    email(original.email)
    {
        std::cout << "student " << this << " copied from " << &original << '\n';
    }

    std::string& get_first_name()
    {
        return first_name;
    }

    std::string& get_last_name()
    {
        return last_name;
    }

    std::string& get_email()
    {
        return email;
    }

    std::string format()
    {
        return std::format("Student({}, {}, {})\n", first_name, last_name, email);
    }

    void display()
    {
        std::cout << format();
    }
};    
