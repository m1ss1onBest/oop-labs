//
// Created by m1ss1on on 9/12/2024.
//

export module Shape;

export class Shape {
public:
    virtual ~Shape() = default;

    virtual void display() = 0;
    virtual float area() = 0;
    virtual float perimeter() = 0;
};
