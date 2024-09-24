#include <format>
#include <iostream>
#include <cmath>
#include <vector>

class Shape {
public:
    virtual ~Shape() = default;

    virtual void display() {
        std::cout << std::format("Perimeter({})", perimeter()) << '\n';
        std::cout << std::format("Area({})", area()) << std::endl;
    }
    virtual float perimeter() = 0;
    virtual float area() = 0;
};

class Rectangle : public Shape {
    float x = 0;
    float y = 0;
public:
    ~Rectangle() override = default;
    Rectangle() = default;
    Rectangle(float x, float y) : x(x), y(y) {}

    void display() override {
        std::cout << std::format("Rectangle({}, {})", x, y) << '\n';
        Shape::display();
    }

    float perimeter() override {
        return 2 * (x + y);
    }

    float area() override {
        return x * y;
    }
};

class Circle : public Shape {
    float radius = 0;
public:
    ~Circle() override = default;
    Circle() = default;
    Circle(float r) : radius(r) {}

    void display() override {
        std::cout << std::format("Circle({})", radius) << '\n';
        Shape::display();
    }

    float perimeter() override {
        return 2 * M_PI * radius;
    }

    float area() override {
        return M_PI * radius * radius;
    }
};

class Triangle : public Shape {
    float a = 0, b = 0, c = 0;
public:
    ~Triangle() override = default;
    Triangle() = default;
    Triangle(float a, float b, float c) : a(a), b(b), c(c) {}

    void display() override {
        std::cout << std::format("Triangle({}, {}, {})", a, b, c) << '\n';
        Shape::display();
    }

    float perimeter() override {
        return a + b + c;
    }

    float area() override {
        double s = perimeter() / 2;
        return sqrt(s * (s - a) * (s - b) * (s - c));
    }
};

void printMenu();

int main() {
    std::vector<Shape*> shapes;
    int command { 1 };
    float m, n, u;

    while (true) {
        printMenu();
        std::cin >> command;
        switch (command) {
            case 1:
                std::cout << "enter (x, y): ";
                std::cin >> m >> n;
                shapes.push_back(new Rectangle(m, n));
            break;

            case 2:
                std::cout << "enter (radius): ";
                std::cin >> m;
                shapes.push_back(new Circle(m));
            break;

            case 3:
                std::cout << "enter (a, b, c): ";
            std::cin >> m >> n >> u;
            if (m + n >= u) {
                if (n + u >= m) {
                    if (m + u >= n) {
                        shapes.push_back(new Triangle(m, n, u));
                    }
                    else {
                        std::cout << "Cannot add triangle with wrong sides" << std::endl;
                    }
                }
            }

            break;

            case 4:
                for (auto& shape: shapes) {
                    shape->display();
                    std::cout << '\n';
                }
            break;

            case 0:
                return 0;
            default:
                break;
        }
    }
}

void printMenu() {
    std::cout
    << "Menu:\n"
    << "1. Add rectangle\n"
    << "2. Add circle\n"
    << "3. Add triangle\n"
    << "4. Display shapes\n"
    << "0. Exit" << std::endl;
}