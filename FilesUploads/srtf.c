	
//Shortest Remaining Time First Algorithm.

#include<stdio.h>
int main()
{
     int at[10],bt[10],x[10];
     int wt[10],tat[10],completion[10];
     int i,min,count=0,time,n;
     int avg_wt=0,avg_tat=0,end;
     
     printf("\nEnter the number of Processes: ");
     scanf("%d",&n);
     for(i=0;i<n;i++)
     {
           printf("\nEnter arrival time of process P[%d] : ",i+1);
           scanf("%d",&at[i]);
     }
     for(i=0;i<n;i++)
     {
           printf("\nEnter burst time of process P[%d]: ",i+1);
           scanf("%d",&bt[i]);
     }
     for(i=0;i<n;i++)
     x[i]=bt[i];
    
      bt[9]=9999;
    
     for(time=0;count!=n;time++)
     {
           min=9;
          for(i=0;i<n;i++)
          {
               if(at[i]<=time && bt[i]<bt[min] && bt[i]>0 )
               min=i;
          }
          bt[min]--;
         
          if(bt[min]==0)
          {
               count++;
               end=time+1;
               completion[min] = end;
               wt[min] = end - at[min] - x[min];
               tat[min] = end - at[min];
          
          }
     }
     printf("\nP_Id \t BurstTime \t ArrivalTime \tWaitingTime \tTurnaroundTime \tCompletionTime");
     for(i=0;i<n;i++)
     {
           printf("\n %d \t   %d        \t     %d       \t     %d       \t     %d      \t     %d",i+1,x[i],at[i],wt[i],tat[i],completion[i]);
           avg_wt = avg_wt + wt[i];
           avg_tat = avg_tat + tat[i];
     }
   
     printf("\n\nAverage waiting time = %lf\n",(float)avg_wt/n);
     printf("Average Turnaround time = %lf",(float)avg_tat/n);
     getch();
     return 0;
}
