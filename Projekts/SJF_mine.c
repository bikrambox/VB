//SJF program in C
//.::SJF::.
#include<stdio.h>
int main()
{

int n,j,temp,temp1,temp2,pr[10],b[10],t[10],w[10],p[10],i;

float att=0,awt=0;

for(i=0;i<10;i++)
            {
                        b[i]=0;w[i]=0;
            }


printf(".::SJF::.");
printf("\n\nEnter the number of processes :");
scanf("%d",&n);
printf("Enter the burst times :");

for(i=0;i<n;i++)
            {
                        scanf("%d",&b[i]);
                        p[i]=i;
            }
for(i=0;i<n;i++)
            {
                        for(j=i;j<n;j++)
                        {
                                    if(b[i]>b[j])
                                    {
                                                temp=b[i];
                                                temp1=p[i];
                                                b[i]=b[j];
                                                p[i]=p[j];
                                                b[j]=temp;
                                                p[j]=temp1;
                                                }
}
}
w[0]=0;
for(i=0;i<n;i++)
w[i+1]=w[i]+b[i];
for(i=0;i<n;i++)
        {
t[i]=w[i]+b[i];
            awt=awt+w[i];
            att=att+t[i];
        }
awt=awt/n;
att=att/n;
printf("\nProcess \t Waiting time \t Turn around time \n");
for(i=0;i<n;i++)
printf("p[%d] \t\t %d \t\t %d \n",p[i],w[i],t[i]);
printf("\nThe average waiting time is %f\n",awt);
printf("The average turn around time is %f\n",att);
return 1;
}
