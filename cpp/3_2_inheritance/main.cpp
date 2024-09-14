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

class Book : public PrintPublication {
public:
    Book(const std::string& title, int year, const std::string& author)
        : PrintPublication(title, year), author(author) {

    }

    void printDetails() const override {
        PrintPublication::printDetails();
        std::cout << "Author: " << author << std::endl;
    }
private:
    std::string author;

};

int main() {
}
