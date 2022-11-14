using System;

namespace TP04
{
    public class Point
    {
        private double x;
        private double y;

        public Point(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public void setX(double x)
        {
            this.x = x;
        }
        public void setY(double y)
        {
            this.y = y;
        }
        public double claculateDistance(Point point)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow(this.x - point.getX(), 2) + Math.Pow(this.y - point.getY(), 2));
            return distance;
        }
        public bool eqaulsTo(Point point)
        {
            return (this.x == point.getX()) && (this.y == point.getY());
        }
        public void translation(double x = 0, double y = 0)
        {
            this.x += x;
            this.y += y;
        }
        public bool linearity(Point a, Point b)
        {
            double area = x * (a.getY() - b.getY()) + a.getX() * (b.getY() - a.getY()) + b.getX() * (y - a.getY());
            return (area == 0);
        }
    }
    public class Line
    {
        private Point p1 = new Point();
        private Point p2 = new Point();
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public void setP1(Point p1)
        {
            this.p1 = p1;
        }
        public void setP2(Point p2)
        {
            this.p2 = p2;
        }
        public Point getP1()
        {
            return p1;
        }
        public Point getP2()
        {
            return p2;
        }
        public bool parallelism(Line ln)
        {
            // parallelism between two lines is true only if the slop of the two are equal
            return (this.slop() == ln.slop());
        }
        public bool intersection(Line ln)
        {
            // if the two lines are parallelism then they do not intersect in any point 
            return !parallelism(ln);
        }
        public bool perpendicular(Line ln)
        {
            // if the product of slop1 and slop2 equals to -1 then the two lines are perpendicular
            return ((this.slop() * ln.slop()) == -1);
        }
        public double slop()
        {
            return ((p2.getY() - p1.getY()) / (p2.getX() - p1.getX()));
        }
    }
    // Utiliser la classe "Point" de l'exercice 3 pour définir d'autres concepts:
    //-Droite(constructeurs, setters et getters, égalité, parallélisme, intersection, perpendicularité)
    //- Cercle(constructeurs setters et getters, égalité, intersection, calcul de circonférence, calcul de l'aire)
    //- Ellipse
    public class Circle
    {
        private Point center = new Point(0, 0);
        private double radius;
        public Circle(Point point, double radius = 0)
        {
            this.center = point;
            this.radius = radius;
        }
        public void setCenter(Point point)
        {
            center = point;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public Point getCenter()
        {
            return center;
        }
        public double getRadius()
        {
            return radius;
        }
        public bool equals(Circle circle)
        {
            return this.radius == circle.radius;
        }
        public bool intersection(Circle circle)
        {
            // They intersect only if the distance between cen1 and cen2  is less than or equal to  (rad1 + rad2)
            return center.claculateDistance(circle.getCenter()) <= this.radius + circle.radius;
        }
        public double circumference()
        {
            return 2 * Math.PI * this.radius;
        }
        public double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


