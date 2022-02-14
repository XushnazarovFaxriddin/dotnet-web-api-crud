# dotnet-web-api-crud
talabalar ustida CRUD(Create Read Update Delete) amallarini bajarish


barcha talabar ro'yxatini olish (GET): ```https://localhost:44348/api/talabalar```

bitta talaba malumotlarini olsish id orqali (GET): ```https://localhost:44348/api/talabalar/4```

Talabalani o'chirish id orqali (DELETE): ```https://localhost:44348/api/talabalar/4```

Yangi talaba yaratish ```https://localhost:44348/api/talabalar``` APIsiga ```{
        "firstName": "Faxriddin",
        "lastName": "Xushnazarov",
        "age": 20,
        "gropName": "1-2KIDT-20",
        "course": 2
}``` ko'rinishidagi JSONni (POST) qilib yuborish kk.

Talaba malumotlarini yangilash id orqali ```https://localhost:44348/api/talabalar/4``` APIsiga ```{
        "firstName": "Faxriddin",
        "lastName": "Xushnazarov",
        "age": 21,
        "gropName": "Kompyuter ilimlari va dasturlash texnologiyalari",
        "course": 3
}``` ko'rinishidagi JSONni (PUT) qilib yuorish kk.
