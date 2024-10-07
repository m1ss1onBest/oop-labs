import brush;

int main(int argc, char* argv[])
{
    brush::display();
    
    brush::set_radius(3);
    brush::display();
    
    brush::create_new("fa31ae", 11);
    brush::display();

    auto* value = brush::get_instance();
    value->display();

    brush::destroy_instance();
    auto* another_value = brush::get_instance();
    another_value->display();
    brush::display();
    return 0;
}
