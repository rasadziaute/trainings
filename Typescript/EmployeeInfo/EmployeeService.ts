import { IEmployee } from "./IEmployee";
export class EmployeeService
{
    emp:IEmployee[];
    details:any[];

    constructor(){
        this.emp=[
            {
                id:1,
                name:'Mayura',
                designation:'Trainer',
                department:'Soft Eng',
                Gender:'Female'
            },

            {
                id:2,
                name:'Sam',
                designation:'HR Manager',
                department:'Human Resource',
                Gender:'Male'
            },
            {
                id:3,
                name:'James',
                designation:'Escalation Manager',
                department:'Support',
                Gender:'Male'
            },
            {
                id:4,
                name:'Smitha',
                designation:'Data Testing Engineer',
                department:'DTS',
                Gender:'Female'
            },
            {
                id:5,
                name:'Swathi',
                designation:'Tech Lead',
                department:'Soft Eng',
                Gender:'Female'
            }

        ]

    }

    public getEmployees()
    {

        return this.emp;
    }

    public getEmployeesbyId(id:number):any
    {
        this.getEmployees();
        this.details=this.emp.filter(e=>e.id===id);
        return this.details;
    }

    public getEmployeeCount():number
    {
        return this.emp.length;
    }

    public getFemaleEmployeeCount():number
    {
        return this.emp.filter(x=>x.Gender=='Female').length;
    }

    public updateEmployeeById(id:number, name?:string, designation?:string, department?:string, gender?:string):void
    {
        for (let i = 0; i < this.emp.length; i++)
        {
            if (this.emp[i].id===id)
            {
                if(name)
                {
                    this.emp[i].name = name;
                }
                if(designation)
                {
                    this.emp[i].designation = designation;
                }
                if(department)
                {
                    this.emp[i].department = department;
                }
                if(gender)
                {
                    this.emp[i].Gender = gender;
                }
            }
        }
    }

    public deleteEmployeeById(id:number):void
    {
        for (let i = 0; i < this.emp.length; i++)
        {
            if (this.emp[i].id===id)
            {
                this.emp.splice(i--, 1);
            }
        }
    }

    public insertEmployee(id:number, name:string, designation:string, department:string, gender:string):void
    {

        let newEmployee = {} as IEmployee;
        newEmployee.id = id;
        newEmployee.name = name;
        newEmployee.designation = designation;
        newEmployee.department = department;
        newEmployee.Gender = gender;

        this.emp.push(newEmployee);
    }

}

