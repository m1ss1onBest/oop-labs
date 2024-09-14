#include <chrono>
#include <iostream>
#include <string>

class PrintPublication {
protected:
    std::pmr::string title;
    int year;

public:
    PrintPublication(const std::string& title, int year)
        : title(title), year(year) {

    }

    virtual ~PrintPublication() = default;
    virtual void printDetails() const {
        std::cout << "Title: " << title << ", Year: " << year << std::endl;
    }

};

int main() {
}
