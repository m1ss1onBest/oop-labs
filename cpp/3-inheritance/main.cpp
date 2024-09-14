#include <iostream>
#include <cmath>
#include <list>
#include <memory>
#include <array>

class Shape {
protected:
    static std::list<std::shared_ptr<Shape>> shapes;
    static int count;
public:
    Shape() {
        count++;
        shapes.push_back(std::shared_ptr<Shape>(this));
    }

    virtual ~Shape() {
        count--;
    }

    virtual void display() = 0;
    virtual float perimeter() = 0;
    virtual float area() = 0;

    static void displayShapes() {
        for (const auto& shape : shapes) {
            shape->display();
        }
    }

    static int getCount() {
        return count;
    }
};

std::list<std::shared_ptr<Shape>> Shape::shapes;
int Shape::count = 0;

class Rectangle : public Shape, public std::enable_shared_from_this<Shape> {
    float x = 0;
    float y = 0;
public:
    Rectangle(float x, float y) : x(x), y(y) {}
    ~Rectangle() override = default;

    void display() override {std::cout << "Rectangle(" << x << ", " << y << ")" << std::endl;}
    float perimeter() override {return 2 * (x + y);}
    float area() override {return x * y;}
};

class Circle : public Shape, public std::enable_shared_from_this<Shape> {
    float radius = 0;
public:
    explicit Circle(float radius) : radius(radius) {}
    ~Circle() override = default;

    void display() override {std::cout << "Circle(" << radius << ")" << std::endl;}
    float perimeter() override {return M_PI * 2 * radius;}
    float area() override {return M_PI * radius * radius;}
};

class Triangle : public Shape, public std::enable_shared_from_this<Shape> {
    std::array<float, 6> points;
public:
    explicit Triangle(const std::array<float, 6>& points_array) : points(points_array) {}

    void display() override {
        std::cout << "Triangle(";
        for (int i = 0; i < 6; ++i) {
            if (i != 0) std::cout << ", " << points[i];
            else std::cout << points[i];
        }
        std::cout << ")" << std::endl;
    }

    float perimeter() override {
        float ab = sqrt(pow(points[2] - points[0], 2) + pow(points[3] - points[1], 2));
        float bc = sqrt(pow(points[4] - points[2], 2) + pow(points[5] - points[3], 2));
        float ac = sqrt(pow(points[4] - points[0], 2) + pow(points[5] - points[1], 2));
        return ab + bc + ac;
    }

    float area() override {
        return 0.5 * std::abs(
            points[0] * (points[3] - points[5]) +
            points[2] * (points[5] - points[1]) +
            points[4] * (points[1] - points[3])
        );
    }
};

int main() {
    auto rect = std::make_shared<Rectangle>(1, 3);
    rect->display();
    std::cout << "area: " << rect->area() << '\n';
    std::cout << "perimeter: " << rect->perimeter() << '\n';
    std::cout << std::endl;

    auto circle = std::make_shared<Circle>(4.34f);
    circle->display();
    std::cout << "Area: " << circle->area() << '\n';
    std::cout << "Perimeter: " << circle->perimeter() << '\n';
    std::cout << std::endl;

    std::array<float, 6> coords {1, -3, 0, 0, 15, 6};
    auto triangle = std::make_shared<Triangle>(coords);
    triangle->display();
    std::cout << "Area: " << triangle->area() << '\n';
    std::cout << "Perimeter: " << triangle->perimeter() << '\n';
    std::cout << std::endl;

    std::cout << "Number of shapes: " << Shape::getCount() << std::endl;
    Shape::displayShapes();

    return 0;
}
