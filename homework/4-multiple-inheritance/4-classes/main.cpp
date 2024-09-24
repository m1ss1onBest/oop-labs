#include <iostream>

#include "classes/re_export.h"

// class names are so stupid because it's needed to name them so in the homework task

int main()
{
    auto b1_class = b1("b1-msg");
    auto b2_class = b2("b2-msg");
    std::cout << '\n' << std::flush;

    auto d1_class = d1("aaa", "bbb");
    std::cout << "we can use static cast to display d1 as b1\n" << std::flush;
    static_cast<b1>(d1_class).display();
    // static_cast<b2>(d_class).display(); error because b2 is inherited as private
    // d1_class.display(); causes error too because of multiple inheritance method it's not implemented
    std::cout << '\n' << std::flush;

    std::cout << "creating new d3 object\n" << std::flush;
    d3 d3_class = d3("message-to-b1", "message-to-b2", "message-to-self");
    std::cout << '\n' << std::flush;

    d2 d2_class = d2("msg-to-mother-class", "msg-to-self");
    std::cout << '\n' << std::flush;

    d4 finalObject = d4("1-msg-to-b2", "2-msg-to-d2", "self-message");
}
