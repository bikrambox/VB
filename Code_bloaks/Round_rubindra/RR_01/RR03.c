#include<stdio.h>
#include<conio.h>
#include<process.h>
#include<string.h>
void main()
{
char p[10][5];
int et[10],wt[10],timer=3,count,pt[10],rt,i,j,totwt=0,t,n=5,found=0,m;
float avgwt;
clrscr();
for(i=0;i<n;i++)
{
printf("enter the process name : ");
scanf("%s",&p[i]);
printf("enter the processing time : ");
scanf("%d",&pt[i]);
}
m=n;
wt[0]=0;
i=0;
do
{
if(pt[i]>timer)
{
rt=pt[i]-timer;
strcpy(p[n],p[i]);
pt[n]=rt;
et[i]=timer;
n++;
}
else
{
et[i]=pt[i];
}
i++;
wt[i]=wt[i-1]+et[i-1];
}while(i<n);
 
count=0;
for(i=0;i<m;i++)
{
for(j=i+1;j<=n;j++)
{
if(strcmp(p[i],p[j])==0)
{
count++;
found=j;
}
}
	if(found!=0)
	{
 
	wt[i]=wt[found]-(count*timer);
	count=0;
	found=0;
	}
}
for(i=0;i<m;i++)
{
totwt+=wt[i];
}
avgwt=(float)totwt/m;
for(i=0;i<m;i++)
{
printf("\n%s\t%d\t%d",p[i],pt[i],wt[i]);
}
printf("\ntotal waiting time %d\n",totwt);
printf("total avgtime %f",avgwt);
}