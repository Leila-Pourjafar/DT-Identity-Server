
تغییرات مربوط به کلاس های ذیل می باشد .
src\Core\Domain\Features\Identity\Users\
ارتباط یک به یک کلاس User , UserProfile 
1.User
2.UserProfile
3.UserAddress 

تعریف دو [ComplexType] جدید در مسیر :src\Core\Domain\SharedKernel :
1.Address
2.PostalCode

کانفیگ : 
src\Infrastructure\Persistence\Configurations\Features\Identity\Users\

فراخوانی و استفاده از کلاس های ایجاد شده : 
src\Presentation\Client\Program.cs

![image](https://github.com/user-attachments/assets/cbd0ab96-6cf3-44dd-8f58-572cfbf4788f)
