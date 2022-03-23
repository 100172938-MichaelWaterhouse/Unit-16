package volume;
import java.util.*;

public class Volume {
    
    double vc=0,vs=0,vcd=0;
    
    void volume(int s){
        vc=s*s*s;
        
        System.out.println("The volume of the cube is "+vc);
    }
    
    void volume(float r){
        vs=(4/3)*(22/7)*r*r*r;
        
        System.out.println("The vol. of sphere is "+vs);
    }
    
    void volume(int l,int b,int h){
        vcd=l*b*h;
        
        System.out.println("The vol. of cuboid is "+vcd);
    }
    
    
    
    public static void main(String[] args){
        int s,l,b,h;
        
        float r;
        Scanner sc=new Scanner(System.in);
        
        System.out.println("Enter the side of the cube");
        s=sc.nextInt();
        
        System.out.println("Enter the radius of the sphere");
        r=sc.nextFloat();
        
        System.out.println("Enter l,b,h of the cuboid");
        l=sc.nextInt();
        b=sc.nextInt();
        h=sc.nextInt();
        Volume obj=new Volume();
        
        obj.volume(s);
        obj.volume(r);
        obj.volume(l,b,h);
        
    }
}